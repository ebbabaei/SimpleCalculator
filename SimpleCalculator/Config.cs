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
        public string ApiToken = "Bearer 9212345abcde67890fghij12345kLMNOPQ";
        public string ApiToken2 = "Bearer 7812345abcde67890fghij12345kLMNOPQ";
        public string ApiToken3 = "Bearer 8512345abcde67890fghij12345kLMNOPQ";
    }

}
