using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager:ISupplierService
{
    
    private IApplicantService _iApplicantService;

    public PttManager(IApplicantService iApplicantService)
    {
        _iApplicantService = iApplicantService;
    }
    
    
    public void GiveMask(Citizen citizen)
    {
        
        if (_iApplicantService.CheckCitizen(citizen))
        {
            Console.WriteLine("For " + citizen.FirstName + " --> Mask is given.");
        }
        else
        {
            Console.WriteLine("For " + citizen.FirstName + " --> Mask is not given!");
        }
    }
}