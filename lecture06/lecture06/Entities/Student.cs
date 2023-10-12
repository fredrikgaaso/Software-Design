namespace Lecture06.Entities; 

public class Student {
    public int Id { get; set; } // PK
    public string Name { get; set; } = string.Empty;
    
    public int EducationId { get; set; } // FK
    
    public Education? Education { get; set; } // Navigation property
    
    public override string ToString() {
        return $"id: {Id}, name: {Name}";
    }

}