using AutoMapper;
using AutoMapper.Execution;
using LibraryManagementSoftwareModels.Business_Model;
using LibraryManagementSoftwareModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSoftwareServices.Additional
{
	public  class MappinProfile:Profile
	{
        public MappinProfile()
        {

			CreateMap<Student, StudentViewModel>();
			CreateMap<StudentViewModel, Student>();

		}


	}
}
