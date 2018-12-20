using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tomware.Microwf.Engine;

namespace WebApi.Workflows.Stepper
{
  [Table("Stepper")]
  public partial class Stepper : IEntityWorkflow
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public string Assignee { get; set; }

    [Required]
    public string Name { get; set; }

    public static Stepper Create(string creator, string name)
    {
      return new Stepper
      {
        Type = StepperWorkflow.TYPE,
        State = StepperWorkflow.NEW_STATE,
        Assignee = creator,
        Name = name
      };
    }
  }
}