//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoApplicationProgect
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskCategory
    {
        public int id { get; set; }
        public int task_id { get; set; }
        public int category_id { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Tasks Tasks { get; set; }
    }
}
