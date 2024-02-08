using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ForeignerManager: IApplicantService
{
    public void ApplyForMask(Citizen citizen)
    {
        
    }

    public List<Citizen> GetList()
    {
        return null;
    }

    public bool CheckCitizen(Citizen citizen)
    {
        return false;
    }
}