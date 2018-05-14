using com.nexusgroup.library.saml;

namespace saml_demo
{
    public partial class Startup
    {
        private static LibrarySamlEngine SamlEngine;

        public void InitializeLibrary(string metadataLocation)
        {
            /* First example */
            try
            {
                SamlEngine = LibrarySamlEngine.Initialize(metadataLocation);
            }
            catch (SamlEngineException e)
            {
                /* handle exception, see second example below */
                throw e;
            }

            /* Second example */
            /*
            try
            {
                SamlEngine = LibrarySamlEngine.Initialize(
                    @"<?xml version=""1.0"" encoding=""UTF-8""?><md:EntityDescriptor entityID=""https://idp.local/idp"" xmlns:md=""urn:oasis:names:tc:SAML:2.0:metadata""><md:IDPSSODescriptor protocolSupportEnumeration=""urn:oasis:names:tc:SAML:2.0:protocol"" WantAuthnRequestsSigned=""false""><md:KeyDescriptor use=""signing""><xd:KeyInfo xmlns:xd=""http://www.w3.org/2000/09/xmldsig#""><xd:X509Data><xd:X509Certificate>MIIDOjCCAiKgAwIBAgIJAMUrirvarZjcMA0GCSqGSIb3DQEBCwUAMDIxCzAJBgNVBAYTAkFVMRMwEQYDVQQIDApTb21lLVN0YXRlMQ4wDAYDVQQKDAVOZXh1czAeFw0xNjEyMDYwODM0MzVaFw00NTA0MjMwODM0MzVaMDIxCzAJBgNVBAYTAkFVMRMwEQYDVQQIDApTb21lLVN0YXRlMQ4wDAYDVQQKDAVOZXh1czCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAMrlhh55EQHIMs1/GG9DA1DGNrewg2QxdglNwzlZZYMxpfPctgJz4JSOLPLDlMADKp0Qe6GS/VmHPlrYZBByiIEHhAY4ltPhMa4ke55eb2HZXrtzWYQcVaVJWyX+R4f6iQJ/ksRy6qt6mx6dFWyUmAU1dk7XXMcf1/xIxWs+xHNI1xWaQTZUTFgeVAdxadC8Tnqwf6osD6KrFN7p8grxDsYCbv3dgecrN27tbdvNgpBYZEa6JfsPHQLTCBq8x8iBsEeQ7tjqmQzQ5EeSsfgLmAlE4miE81bhIPqYBMd2d9iQEm4bOOaJ9+xzZx2JYodahS+0uN5noQB2TmaXQ+noDe0CAwEAAaNTMFEwHQYDVR0OBBYEFDs1zbZwpC+Uyb72FbIi8XrYOKbIMB8GA1UdIwQYMBaAFDs1zbZwpC+Uyb72FbIi8XrYOKbIMA8GA1UdEwEB/wQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAHvxbx6KizKDd0er7gd5eX+n/FuxRs+S1e95fGGpJGPWuVIeXmmgP9UyfmVmJIQLgUljn96syFCo87h9ObvI5HDEeyt/lqgDcy3GSJJLXf6ccuSbRiWliWxaQSffCJvBpKgUOn1knpi/Tzi2UTCingXVxF1SUX82y3qsMQ/11pht8CzRVzYi7IN06DrWhOH4t77LT92BErYS1TRXW+nZ/t4CvKu9GA+C6VShDBzUM+AvNW6Vzxknhmw/ZtwRzvtAV0Hvs5PJetQkSMkkQ96TQyynLfP4l/ah44i8SK9y4pwkH6rJb/5f8HkvqrjzwVL59JKCAmHzTRRB7oLF6CrqHCg=</xd:X509Certificate></xd:X509Data></xd:KeyInfo></md:KeyDescriptor><md:NameIDFormat>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</md:NameIDFormat><md:NameIDFormat>urn:oasis:names:tc:SAML:2.0:nameid-format:transient</md:NameIDFormat><md:NameIDFormat>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress</md:NameIDFormat><md:NameIDFormat>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified</md:NameIDFormat><md:SingleSignOnService Binding=""urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"" Location=""https://localhost/wa/auth/saml/""/><md:SingleSignOnService Binding=""urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"" Location=""https://localhost/wa/auth/saml/""/><md:SingleSignOnService Binding=""urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"" Location=""https://developing.nu/wa/auth/saml/""/><md:SingleSignOnService Binding=""urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"" Location=""https://developing.nu/wa/auth/saml/""/></md:IDPSSODescriptor></md:EntityDescriptor>",
                    @"<?xml version=""1.0"" encoding=""UTF-8""?><md:EntityDescriptor entityID=""urn:localhost:6wwu5ptro6yfq7i"" xmlns:md=""urn:oasis:names:tc:SAML:2.0:metadata""><md:SPSSODescriptor protocolSupportEnumeration=""urn:oasis:names:tc:SAML:2.0:protocol"" WantAssertionsSigned=""false"" AuthnRequestsSigned=""false""><md:AssertionConsumerService Binding=""urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"" isDefault=""true"" index=""0"" Location=""https://localhost:44306/Account/Login""/></md:SPSSODescriptor></md:EntityDescriptor>"
                );
            }
            catch (SamlEngineException e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry(e.Message, EventLogEntryType.Error);
                }
            }
            */
        }

        public static LibrarySamlEngine GetLibrary()
        {
            return SamlEngine;
        }
    }
}