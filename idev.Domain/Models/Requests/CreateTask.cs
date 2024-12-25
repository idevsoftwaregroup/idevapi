using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idev.Domain.Models.Requests;


public class CreateTask
{
    [Key]
    public int Id { get; set; }
    public required string TaskName { get; set; }
    public string TaskType { get; set; } = string.Empty;
    public string TaskDetails { get; set; } = string.Empty;
    public Status Status { get; set; }
}
public class Status
{
    [Key]
    public int Id { get; set; }
    public bool TaskStatus { get; set; }
}