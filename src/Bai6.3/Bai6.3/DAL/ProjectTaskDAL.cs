using System;
using System.Data;
using MySql.Data.MySqlClient;
using Bai6._3.DTO;

namespace Bai6._3.DAL
{
    public class ProjectTaskDAL : DatabaseAccess
    {
        // 1. Quản lý Dự án & Thành viên
        public DataTable GetListDuAn() => ExecuteQuery("SELECT * FROM DuAn");
        public DataTable GetListThanhVien() => ExecuteQuery("SELECT * FROM ThanhVien");

        // 2. Lấy danh sách Task (Lọc theo Dự án & Trạng thái)
        public DataTable GetTasksByFilter(int maDuAn, string trangThai)
        {
            string query = @"SELECT cv.MaTask, cv.TenTask, cv.MoTa, cv.HanNop, cv.DoUuTien, cv.TrangThai, 
                                    IFNULL(GROUP_CONCAT(tv.HoTen SEPARATOR ', '), 'Chưa phân công') AS NguoiThucHien
                             FROM CongViec cv
                             LEFT JOIN PhanCong pc ON cv.MaTask = pc.MaTask
                             LEFT JOIN ThanhVien tv ON pc.MaThanhVien = tv.MaThanhVien
                             WHERE (@MaDuAn = 0 OR cv.MaDuAn = @MaDuAn)
                               AND (@TrangThai = 'Tất cả' OR cv.TrangThai = @TrangThai)
                             GROUP BY cv.MaTask";

            MySqlParameter[] p = {
                new MySqlParameter("@MaDuAn", maDuAn),
                new MySqlParameter("@TrangThai", trangThai)
            };
            return ExecuteQuery(query, p);
        }

        // 3. Thêm mới Task
        public bool InsertTask(CongViecDTO task)
        {
            string query = @"INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai)
                             VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai)";
            MySqlParameter[] p = {
                new MySqlParameter("@MaDuAn", task.MaDuAn),
                new MySqlParameter("@TenTask", task.TenTask),
                new MySqlParameter("@MoTa", task.MoTa),
                new MySqlParameter("@HanNop", task.HanNop),
                new MySqlParameter("@DoUuTien", task.DoUuTien),
                new MySqlParameter("@TrangThai", task.TrangThai)
            };
            return ExecuteNonQuery(query, p) > 0;
        }

        // 4. Cập nhật trạng thái Task (Parameterized SQL)
        public bool UpdateStatus(int maTask, string trangThaiMoi)
        {
            string query = "UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask";
            MySqlParameter[] p = {
                new MySqlParameter("@TrangThai", trangThaiMoi),
                new MySqlParameter("@MaTask", maTask)
            };
            return ExecuteNonQuery(query, p) > 0;
        }

        // 5. Phân công công việc cho thành viên
        public bool AssignTask(int maTask, int maThanhVien)
        {
            string query = "INSERT IGNORE INTO PhanCong (MaTask, MaThanhVien, NgayGiao) VALUES (@MaTask, @MaTV, NOW())";
            MySqlParameter[] p = {
                new MySqlParameter("@MaTask", maTask),
                new MySqlParameter("@MaTV", maThanhVien)
            };
            return ExecuteNonQuery(query, p) > 0;
        }

        // 6. Cảnh báo trễ hạn (Overdue Task) bằng DataReader/DataTable
        public DataTable GetOverdueTasks()
        {
            string query = @"SELECT cv.MaTask, da.TenDuAn, cv.TenTask, cv.HanNop, cv.TrangThai
                             FROM CongViec cv
                             JOIN DuAn da ON cv.MaDuAn = da.MaDuAn
                             WHERE cv.HanNop < NOW() AND cv.TrangThai != 'Done'";
            return ExecuteQuery(query);
        }

        // 7. Thống kê tỷ lệ hoàn thành công việc từng thành viên (GROUP BY / ExecuteScalar)
        public DataTable GetMemberTaskStatistics()
        {
            string query = @"SELECT tv.HoTen,
                                    COUNT(pc.MaTask) AS TongTask,
                                    SUM(CASE WHEN cv.TrangThai = 'Done' THEN 1 ELSE 0 END) AS TaskHoanThanh,
                                    ROUND(IFNULL((SUM(CASE WHEN cv.TrangThai = 'Done' THEN 1 ELSE 0 END) / COUNT(pc.MaTask)) * 100, 0), 1) AS TyLeHoanThanh
                             FROM ThanhVien tv
                             LEFT JOIN PhanCong pc ON tv.MaThanhVien = pc.MaThanhVien
                             LEFT JOIN CongViec cv ON pc.MaTask = cv.MaTask
                             GROUP BY tv.MaThanhVien, tv.HoTen";
            return ExecuteQuery(query);
        }
    }
}