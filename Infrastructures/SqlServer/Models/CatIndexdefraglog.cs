using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class CatIndexdefraglog
    {
        public int Id { get; set; }
        public int ExecutionId { get; set; }
        public string ObjectName { get; set; }
        public string IndexName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? SucceedState { get; set; }
        public double? Fragmentation { get; set; }
        public string CommandText { get; set; }
        public string Message { get; set; }
    }
}
