//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sqlProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questions()
        {
            this.choices = new HashSet<choices>();
            this.stud_exam = new HashSet<stud_exam>();
        }
    
        public int question_id { get; set; }
        public string question { get; set; }
        public string model_answer { get; set; }
        public string type { get; set; }
        public Nullable<int> answer_id { get; set; }
        public int course_id { get; set; }
        public Nullable<int> grade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<choices> choices { get; set; }
        public virtual courses courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stud_exam> stud_exam { get; set; }
    }
}
