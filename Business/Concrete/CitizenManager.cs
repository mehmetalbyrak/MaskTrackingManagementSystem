using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete;

public class CitizenManager: IApplicantService
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
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
        var result = client.TCKimlikNoDogrulaAsync(citizen.NationalIdentity,
            citizen.FirstName, citizen.LastName, citizen.DateOfBirthYear);
        return result.Result.Body.TCKimlikNoDogrulaResult;
    }
}