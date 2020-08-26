using GridLayoutInLazyCore.Model.Dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductX.BusinessLogic.WebApi
{
    public interface IWebApiClient
    {
        Task<ValidationResponse> Validate();
        Task<string> GetVideoConfig(string uri);
        
        //Task<int> CompleteJobAsync(CompleteJobRequest request);
        //Task<List<CompletedJob>> GetCompletedJobAsync();
        //Task<JobAttachmentResult> AddAttachmentAsync(int jobId, JobAttachmentType jobAttachmentType, byte[] attachmentData);
    }
}
