using LinkBoxWeb.DataModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkBoxWeb.Models
{
    public class CreateContentViewModel
    {
        public int SubjectId { get; set; }
        public int TopicId { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string LinkHref { get; set; }
        public bool IsExercise { get; set; }
        public List<SelectListItem> Subjects { get; set; }
        public List<SelectListItem> Topics { get; set; }
    }
}
