
## Cấu trúc thư mục MVC
- Controllers: Nơi chứa các controller xử lý request
- Views: Chứa các file giao diện .cshtml
- Models: Chứa các lớp dữ liệu
- wwwroot: Chứa css, js, image
- Program.cs: Cấu hình ứng dụng, routing
- appsettings.json: Các cấu hình môi trường
## Routing trong .NET MVC
Routing quy định URL được map vào Controller và Action nào.

Cấu hình mặc định trong Program.cs:

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

=> Nếu không nhập gì vào URL thì chạy HomeController > Index()
## Namespace trong C#
Namespace dùng để gom nhóm các class lại theo từng thư mục.
Giúp tránh trùng tên và tổ chức code rõ ràng.

Ví dụ:
namespace DemoMVC.Controllers
{
   public class HomeController : Controller
   {
   }
}
## Controller và View
- Controller: Class xử lý request, trả dữ liệu hoặc trả View.
- View: File .cshtml để hiển thị giao diện.
- Mỗi action trong controller sẽ tương ứng 1 file View.