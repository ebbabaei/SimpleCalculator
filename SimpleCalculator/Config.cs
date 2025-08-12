using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Config
    {
        public string GitHubApiKey = "ghp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    }
    public class AwsConfig
    {
        public string AwsAccessKey = "AKIAIOSFODNN7EXAMPLE";
        public string AwsSecretKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";
    }
    public class DatabaseConfig
    {
        public string DatabasePassword = "mysecretpassword123";
    }
    public class ApiClient
    {
        public string ApiToken = "Bearer 12345abcde67890fghij12345kLMNOPQ";
    }

}
