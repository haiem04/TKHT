//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TKHT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attempt_Question
    {
        public string Answer { get; set; }
        public int AttemptId { get; set; }
        public int QuestionId { get; set; }
    
        public virtual Attempt Attempt { get; set; }
        public virtual Question Question { get; set; }
    }
}
