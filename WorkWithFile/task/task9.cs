namespace WorkWithFile;

internal class Program
{
    static void Main(string[] args)
    {
        var filePath = "server.log";
        var fileErrors = "errors_only.txt";

        var text = @"[INFO] Server started successfully
[INFO] Database connection established
[ERROR] Failed to connect to cache server
[INFO] User login: admin
[INFO] Request processed: /api/users
[ERROR] Null reference exception in UserService
[INFO] Response sent: 200 OK
[INFO] Memory usage: 45%
[ERROR] Timeout connecting to external API
[INFO] Cache updated successfully
[INFO] New user registered: user123
[INFO] File uploaded: document.pdf
[ERROR] Disk space low on drive C:
[INFO] Scheduled task executed
[INFO] Email sent to user@example.com
[ERROR] Database deadlock detected
[INFO] Session created for user456
[INFO] API call: GET /api/products
[ERROR] Invalid authentication token
[INFO] Background job started
[INFO] Configuration reloaded
[ERROR] Out of memory exception
[INFO] Request processed: /api/orders
[INFO] Payment processed successfully
[ERROR] Network connection lost
[INFO] Service health check: OK
[INFO] Log rotation completed
[ERROR] Failed to parse JSON response
[INFO] User logout: admin
[INFO] Database backup started
[ERROR] Permission denied for file access
[INFO] Transaction committed
[INFO] Cache cleared
[ERROR] SQL injection attempt detected
[INFO] Security scan completed
[INFO] New order created: #12345
[ERROR] Service unavailable: PaymentGateway
[INFO] User profile updated
[INFO] Search query executed
[ERROR] Rate limit exceeded for IP 192.168.1.1
[INFO] Notification sent successfully
[INFO] Session expired for user789
[ERROR] Corrupt data in configuration file
[INFO] Metrics collected
[INFO] Report generated
[ERROR] External service timeout
[INFO] Backup completed successfully
[INFO] Application shutdown initiated
[ERROR] Failed to write to log file
[INFO] Cleanup process finished
[INFO] Server stopped gracefully"; // GPT

        File.WriteAllText(filePath, text);

        using (StreamReader reader = new StreamReader(filePath))
        {
            using (StreamWriter writer = new StreamWriter(fileErrors))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                    if (line.StartsWith("[ERROR]"))
                        writer.WriteLine(line);
            }
        }

    }
}
