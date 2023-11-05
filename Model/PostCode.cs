using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningProject.Model
{

    [Table("POST_CODE_COVERAGE_INFORMATION")]
    public class PostCode
    {
        [Key]
        public long ID { set; get; }
        public string DISTRICT_OFFICE_NAME { set; get; }
        public string COVERAGE_AREA { set; get; }
        public string POST_CODE { set; get; }
        public string DC_AREA_CODE { set; get; }
        public string DIVISION { set; get; }
        public string DISTRICT { set; get; }
        public string DISTRICT_CITY { set; get; }
        public string PATHAO_AREA_MAP { set; get; }
        public string RADEX_AREA_MAP { set; get; }
        public string PAPERFLY_AREA_MAP { set; get; }
        public string PARTNER_KOREAR_COMPANY { set; get; }
    }
}
