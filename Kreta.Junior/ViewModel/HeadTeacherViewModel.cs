using Kreta.Junior.Model;
using Kreta.Junior.Repo;

namespace Kreta.Junior.ViewModel
{
    public class HeadTeacherViewModel
    {
        private HeadTeacherRepo _headTeacherRepo=new();

        public HeadTeacherViewModel()
        {
        }

        public string OsziOtto => string.Empty;
        public string SeniorHeadTeacher => string.Empty;
       
        public string NumberOfAssistantHeadTeacher => string.Empty;

        public string NumberOfNoAssistantHeadTeacher => string.Empty;
    }
}
