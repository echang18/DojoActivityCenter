using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivityCenter.Models
{
    public class Plan
    {
        [Key]
        public int PlanId {get;set;}

        [Required(ErrorMessage = "Activity is required")]
        public string PlanTitle {get;set;}
        [Required(ErrorMessage="Activity date is required")]
        [DataType(DataType.Date,ErrorMessage="Must be a future date")]
        [FutureDate]
        public DateTime PlanStart {get;set;}
        [Required(ErrorMessage="Activity duration is required")]
        public int PlanDuration {get;set;}
        [Required(ErrorMessage="Min/Hr/Day is required")]
        public string DurationTime {get;set;}
        [Required(ErrorMessage ="Description is required")]
        public string PlanDescription {get;set;}

        public int PlannerId {get;set;}
        public User Planner {get;set;}

        public List<Join> Attendees {get;set;}
    }
}