using Azure.Core;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text;

namespace StudentAdmission.API.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                //var request = context.Request;
                //var body = request.Body;

                ////This line allows us to set the reader for the request back at the beginning of its stream.
                //request.EnableBuffering();

                ////We now need to read the request stream.  First, we create a new byte[] with the same length as the request stream...
                //var buffer = new byte[Convert.ToInt32(request.ContentLength)];

                ////...Then we copy the entire request stream into the new buffer.
                //await request.Body.ReadAsync(buffer, 0, buffer.Length);

                ////We convert the byte[] into a string using UTF8 encoding...
                //var bodyAsText = Encoding.UTF8.GetString(buffer);

                //string requestDetails = $"{DateTime.Now} - {context.Request.Method} - {context.Request.Path} = {bodyAsText}";
                //LogFile(requestDetails);

                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync(ex.Message);
                LogFile(ex.Message);
            }
        }

        private void LogFile(string logMessage)
        {
            string logFilePath = "logs.txt";

            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine(logMessage);
            }
        }
    }
}
