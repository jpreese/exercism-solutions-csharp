using System.Collections.Generic;
using System.Linq;

public class School
{
    private readonly Dictionary<string, int> _students = new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        _students.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return _students
            .OrderBy(s => s.Value)
            .ThenBy(s => s.Key)
            .Select(s => s.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _students
            .Where(s => s.Value == grade)
            .OrderBy(s => s.Key)
            .Select(s => s.Key);
    }
}