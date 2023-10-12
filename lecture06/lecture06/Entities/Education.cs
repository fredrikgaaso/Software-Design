namespace Lecture06.Entities; 

public class Education {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Student>? Student { get; set; }
    
    public override string ToString() {
        return $"id: {Id}, name: {Name}";
    }
}