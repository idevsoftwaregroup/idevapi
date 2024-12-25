using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idev.Domain.Models.DTOs;


public class TaskManager
{
    [Key]
    public int Id { get; set; }
    public string TaskName { get; set; }
    public string TaskType { get; set; }
    public string TaskDetails { get; set; }
    public Status Status { get; set; }
}
public class Status
{
    [Key]
    public int Id { get; set; }
    public bool TaskStatus { get; set; }
}

