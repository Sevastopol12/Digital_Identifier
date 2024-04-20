***Mục tiêu

+Tạo ra một bản định danh kỹ thuật số bằng Cấu trúc Binary tree. Cùng giao diện lập trình 
+Một bản định danh kỹ thuật số thường bao gồm một khóa (ID), password và dữ liệu liên quan.


***Note 

+Binary Tree class = Class DigiDen
+Tree's node = Class ID


***Thành phần

+Binary Tree: Một tree class chứa các phương thức để Insert một bản định danh mới cùng với việc truy xuất dữ liệu hiện có.
+ Biểu diễn dữ liệu: Mỗi bản định danh sẽ được biểu diễn bởi một node trong tree class. Mỗi node sẽ chứa một giá trị khóa độc nhất (ID) và password, cả hai sẽ được sử dụng cho xác thực dữ liệu, và dữ liệu của của bản định danh đó. 
*Note: Node cũng sẽ chứa 2 node con để lưu trữ thêm dữ liệu (dựa trên cấu trúc của binary tree)

+ Insert & Search method: Tree có các phương thức để insert dữ liệu mới trong khi lưu trữ những dữ liệu hiện có. Ngoài ra, nó cung cấp các phép tìm kiếm để truy xuất dữ liệu của bản định danh dựa trên các khóa của chúng.


***Triển khai

+ Tree class được khởi tạo dựa trên các nguyên tắc lập trình hướng đối tượng, với các phương thức riêng biệt cho Insert, Search,....
+ Các bản định danh được Insert vào binary tree dựa trên các key và password của chúng, với cây tự động tổ chức chúng để duy trì tính chất của cây tìm kiếm nhị phân.




Dựa theo thuật toán của cây nhị phân:
+ Trong class cây nhị phân (DigiDen), ta sẽ tạo thêm một định nghĩa của một class có tên gọi là ID với ý tưởng sẽ khởi tạo class này nhiều lần,class này được sử dụng để tượng trưng cho một node (class instance). Trong cây, ngoài node class, ta còn có các method( hàm) được dùng để thêm hoặc tìm kiếm một node dựa trên ID và password được chứa trong node đó. 

Bên trong class của cây nhị phân, ta sẽ luôn có một object gọi là root ( node gốc rễ của cây, một object được mặc định khởi tạo để làm nền tảng cho việc khởi tạo các node sau này). 



***Idea :>***

+Với mỗi id + password được thêm vào, ta sẽ tạo ra một node instance, mỗi node sẽ được mặc định chứa 2 object left và right ( thứ mà sau này ta sẽ gán cho nó thêm một node nữa). 

Giả sử lần đầu khởi tạo node, ta sẽ phải thêm các thông tin cơ bản (bắt buộc) vào trong node class (ID, password, data). Có thể tưởng tượng rằng, những thông tin này sẽ được truyền qua khắp các node của cây để tìm kiếm vị trí thích hợp để khởi tạo node dựa trên thuật toán:
	
	+Trường hợp 1: vị trí đang trống, ta sẽ khởi tạo một instance của node class tại điểm đó chứa các dữ liệu được đưa vào.

	+Trường hợp 2: vị trí đã có một node khác, ta sẽ xét theo số ID để sắp xếp, với ID hiện tại < ID của node tại vị trí đang xét, ta sẽ " thử " khởi tạo một node instance tại left object của node đó, trường hợp lớn hơn thì đặt tại right object ( left & right mặc định của node).

	+ Nếu tại left/right object vẫn tồn tại một node khác thì ta lại tiếp tục xét như trường hợp 2. Ý tưởng này sẽ được thực thi sử dụng recursion.
	
Có thể tưởng tượng rằng, với dữ liệu được đưa vào thông qua hàm insert (thêm ._.), ta sẽ đóng gói nó lại và chạy dọc theo cây dựa trên thuật toán, nếu tìm thấy vị trí trống thì ném gói này vào đó.


Khá dễ hiểu...nhỉ? :>


***Dữ liệu trong node 

*Note: Đây là những dữ liệu giả được đưa vào bên trong hệ thống để phục vụ mục đích thử nghiệm :>

data sẽ được đọc từ một file CSV ( cụ thể là từ MOCK_DATA_transformed, có một phiên bản dễ đọc hơn là MOCK_DATA), data trong file này sẽ được lưu trữ dưới dạng dictionary để thuận tiện cho việc hash :>. File sẽ được đọc bằng cách sử dụng TextFieldParser ( một hàm chuyên biệt để đọc các file CSV)




# Welp, hiện tại giao diện vẫn đang thiếu phần update thông tin.








