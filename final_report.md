## 1. Phân công nhiệm vụ
  - Lê Mạnh Hùng:
    - Review code, merge code từ các branch chức năng.
    - Tạo api-server để kết nối, lưu thông tin từ Game Unity, deploy lên heroku.
  - Lê Hoàng Long: Thêm text, sửa format text và tạo một số panel bị thiếu.
  - Trần Thu Hiền: Thiết kế, thay đổi lại UI, thay lại một số icon cũ.
  - Nguyễn Tiến Phúc: Code phần Post/Put/Get các thông tin như coin/star/user lên server.
  - Nguyễn Minh Sơn: 
    - Hiển thị thông tin số coins của từng người chơi lên bảng xếp hạng.
    - Viết báo cáo hàng tuần.
## 2. Các công việc đã làm được
### 2.1. Add Text
  - Học cách sử dụng TextmeshPro để xử lý text.
  - Thêm Text vào các mục sau:
      - Giao diện chính của game
      - Phần thông báo của game
      - Thêm  và chỉ sửa phần thông số vật phẩm in game
      - Giao dịch coin
      - Setting game
      - Thêm text vào các Dialog giao dịch coin để mua vật phẩm và lượt chơi
      - Thêm Text vào phần ending game:
      - Thêm text vào phần thông báo cuối màn chơi.
      - Tạo thêm bảng thống kê điểm sau mỗi màn chơi
### 2.2. Design lại UI của Game
  Tự design lại UI của room, tham khảo giao diện game My Home: Design Dream: https://play.google.com/store/apps/details...
  Thay giao diện nội thất trong room:
  - Học cách edit giao diện nội thất trong từng room của Game.
  - Đã thay một số giao diện nội thất trong Room Scene. 
  Thay các icon của Game:
  - Chỉnh sửa và thiết kế icon (Tham khảo game My Home: Design Dream):
      - Extract assets từ apk game My Home Design Dream https://play.google.com/store/apps/details...
      - Design lại assets đã extract và thay vào Game.
  - Đã thay thế các icon đã chỉnh sửa ở các mục sau:
      - icon trong DecorateRoomScreen ở Scene MainUI.
      - Các icon còn lại trong Scene MainUI.
      - Thay icon trong Scene Match3Game.
### 2.3. Làm quen và sử dụng C#
  - Học cú pháp C# cơ bản.
  - Học được cách viết C# để tương tác với các component trong game như Button, Panel, Text.
     ex:  Đọc `username` từ file text và hiển thị dòng chữ 'Hello, `username`' trong mỗi màn chơi 
### 2.4. Kết nối với Api Server
  - Tìm hiểu về các khái niệm RESTful APIs, Json data.
  - Tạo Server:
      - Dựng server đơn giản trên local sử dụng thư viện json-server để lưu các thông tin coins, stars, users dưới dạng JSON.
      - Deploy server lên host heroku. https://lmh-json-api.herokuapp.com/
  - Tìm hiểu về cách viết C# để gọi RESTful APIs:
      - Viết code C# để get data từ resource trên và hiển thị lên game.
      - Post/Put thông tin về coins/stars sau mỗi màn chơi.
  - Tạo được bảng điểm thống kê sau mỗi trận.
      - Get data về số coins của những người chơi và hiển thị theo thứ tự 4 người có điểm cao nhất
  - Lưu được thông tin của người chơi.
      - Tạo file user.txt trên local chứa tên của người chơi `username`.
      - Mỗi khi Post/put data lên server thì Post kèm thông tin đó.

## 3. Tổng kết
Qua việc làm dự án Game Unity cho môn học Công nghệ phần mềm, các thành viên trong nhóm học được:
   - Các khái niệm trong Unity và cách lập trình Game đơn giản với Unity.
   - Cách kết nối từ Game Unity với một server api nhằm lưu trữ, so sánh thông tin.
   - Tinh thần làm việc nhóm, kĩ năng phân chia công việc và trao đổi về từng nhiệm vụ của mỗi thành viên.
   - Quy trình sử dụng Github để làm việc trong 1 dự án gồm nhiều thành viên.
      - Dùng Kanban trên Github Project kết hợp Github Issue để quản lý tiến độ, phân chia công việc
      - Sử dụng thành thạo cái khái niệm của Git như branch, pull request,... Kĩ năng này được cải thiện dần trong quá trình làm project, thời gian đầu còn một số commit bị conflict, xong dần đã ít hơn và Workflow chuẩn hơn.
      
