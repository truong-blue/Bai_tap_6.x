using System.Data;
using Bai6._3.DAL;
using Bai6._3.DTO;

namespace Bai6._3.BUS
{
    public class ProjectTaskBUS
    {
        private ProjectTaskDAL dal = new ProjectTaskDAL();

        public DataTable GetListDuAn() => dal.GetListDuAn();
        public DataTable GetListThanhVien() => dal.GetListThanhVien();
        public DataTable GetTasksByFilter(int maDuAn, string trangThai) => dal.GetTasksByFilter(maDuAn, trangThai);
        public bool InsertTask(CongViecDTO task) => dal.InsertTask(task);
        public bool UpdateStatus(int maTask, string trangThaiMoi) => dal.UpdateStatus(maTask, trangThaiMoi);
        public bool AssignTask(int maTask, int maThanhVien) => dal.AssignTask(maTask, maThanhVien);
        public DataTable GetOverdueTasks() => dal.GetOverdueTasks();
        public DataTable GetMemberTaskStatistics() => dal.GetMemberTaskStatistics();
    }
}