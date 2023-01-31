//NameSorter class handles the sorting of names
internal class Sorter
{
    //Sort method takes in a List of strings and sorts them first by last name,
    //then by any given names the person may have
    public List<string> Sort(List<string> names)
    {
        return names.OrderBy(n => n.Split(' ').Last())
                    .ThenBy(n => n.Split(' ').Length > 0 ? n.Split(' ')[0] : "")
                    .ThenBy(n => n.Split(' ').Length > 1 ? n.Split(' ')[1] : "")
                    .ThenBy(n => n.Split(' ').Length > 2 ? n.Split(' ')[2] : "")
                    .ToList();
    }
}