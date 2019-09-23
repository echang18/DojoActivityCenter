using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DojoActivityCenter.Models
{
    public class Join
    {
        [Key]
        public int JoinId {get;set;}
        public int UserId {get;set;}
        public User Joiner {get;set;}
        public int PlanId {get;set;}
        public Plan JoinedPlan {get;set;}
    }
}