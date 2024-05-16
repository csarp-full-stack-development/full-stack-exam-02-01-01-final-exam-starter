using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.HttpService.Services;
using Kreta.Shared.Responses;
using Kreta.Desktop.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models;
using System.Windows.Documents;
using System.Collections.Generic;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : BaseViewModel
    {
        private readonly IStudentService? _studentService;
        private readonly IEducationLavelService? _educationLevelService;

        public StudentViewModel()
        {
        }

        public StudentViewModel(IStudentService? studentService,
                                IEducationLavelService? educationLevelService
                               )
        {

            _studentService = studentService;
            _educationLevelService = educationLevelService;
        }

        public async override Task InitializeAsync()
        {
            await base.InitializeAsync();
        }
    }
}
