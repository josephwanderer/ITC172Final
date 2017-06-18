using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAssistServiceService" in both code and config file together.
[ServiceContract]
public interface IAssistServiceService
{
    [OperationContract]
    bool RegisterPerson(string lastname, string firstname, string email, string password, string aptnumber, string street, string city, string state, string zipcode, string homephone, string workphone);

    [OperationContract]
    int Login(string email, string password);

    [OperationContract]
    int RequestGrant(int granttype, string requestexplanation, decimal amount, int userkey);

    [OperationContract]
    List<GrantRequestInfo> ViewGrants(int userkey);

    [OperationContract]
    List<string> GetGrantTypes();

    [OperationContract]
    List<DonationInfo> GetDonations(int userkey);

    [OperationContract]
    void SubmitDonation(int userkey, decimal amount);


}

[DataContract]
public class GrantRequestInfo
{
    [DataMember]
    public DateTime GrantRequestDate { get; set; }
    [DataMember]
    public string GrantRequestExplanation { get; set; }
    [DataMember]
    public decimal GrantRequestAmount { get; set; }
    [DataMember]
    public string GrantReviewDate { get; set; }
    [DataMember]
    public string GrantStatus { get; set; }
    [DataMember]
    public decimal GrantAllocatedAmount { get; set; }

}
[DataContract]
public class DonationInfo
{
    [DataMember]
    public DateTime DonationDate { get; set; }
    [DataMember]
    public decimal DonationAmount { get; set; }
}

