public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

public class Individual : Customer
{
    public string PersonalId { get; set; }
}

public class Corporate : Customer
{
    private string companyName;
    private string taxNumber;
    
    public string CompanyName 
    {
        get { return companyName; }
        set { companyName = value; }
    }
    
    public string TaxNumber 
    {
        get { return taxNumber; }
        set { taxNumber = value; }
    }
}

public class IndividualCustomerManager
{
    private List<Individual> individuals = new List<Individual>();
    
    public void Add(Individual customer)
    {
        individuals.Add(customer);
    }
    
    public List<Individual> GetList()
    {
        return individuals;
    }
    
    public Individual GetById(int id)
    {
        return individuals.FirstOrDefault(c => c.Id == id);
    }
    
    public void Delete(int id)
    {
        var customer = GetById(id);
        if (customer != null)
        {
            individuals.Remove(customer);
        }
    }
}
