namespace POC_NET7.Services;

public interface IDopaService
{

    public string getAddressByPostCode(int PostCode);
    public string getUserProfileByIdCardNumber(int idCard);

}