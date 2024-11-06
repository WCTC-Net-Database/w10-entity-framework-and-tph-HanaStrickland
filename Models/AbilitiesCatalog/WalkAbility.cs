namespace W9_assignment_template.Models.AbilitiesCatalog;

public class WalkAbility: Ability 
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}

    // Navigation property to Characters
    public ICollection<Character> Characters { get; set; }
}