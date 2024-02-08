using Entities.Concrete;

namespace Business.Abstract;

public interface IApplicantService
{
    
    // Sonar Qube --> Check out 
    void ApplyForMask(Citizen citizen);


    List<Citizen> GetList();


    bool CheckCitizen(Citizen citizen);
}