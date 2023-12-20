using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsBL;
using AutoMapper;
namespace Dto_Exams
{
   public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ExamsRepository, ExamsDto>();

        }

    
       
    }
}
