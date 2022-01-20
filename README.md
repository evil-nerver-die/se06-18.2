# se06-18.2

## Introduction 
Lập trình game với Unity #1

Design beautiful homes in bright and sunny places and solve 
hundreds of fun match 3 puzzles in a light and fun match 3 home 
makeover game.
Meet Miss Robins, a young bright designer, and help design the 
decor and furniture to renovate beautiful houses.
- Hone your design skills by designing the home decor and 
furniture.
- Match candy and create power-ups
- Lot's of match-3 levels to enjoy
- Light and Fun Gameplay

## How to setup

Use Unity 2020.2.7f1 to open the project
- JDK version: jdk1.8.0_77
- gradle version: gradle 6.9
- Android 11.0 
- Android SDK build tool 30.0.3

In your Unity editor, choose File/ Build Settings and then click 
Player Settings Button. In Publishing Setting set new keystore password then click Build to build apk file.

## Task lists
- [x] Design game scenes, replace some icon.
- [x] Add text.
- [ ] Connect with Api server.

## Members:
- Le Hoang Long
- Le Manh Hung
- Nguyen Minh Son
- Nguyen Tien Phuc
- Tran Thu Hien

# 1.Phân công nhiệm vụ
    - Add text và create dialog vào game: Lê Hoàng Long.
    - Design UI, thay icon: Trần Thu Hiền.
    - Kết nối Api Server: Lê Mạnh Hùng, Nguyễn Minh Sơn, Nguyễn Tiến Phúc.
    - Tester: Lê Mạnh Hùng.
# 2. Các công việc đã làm được
### 2.1. Add Text
    - Tìm file xml chứa text và component cần thêm script.
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
### 2.3. Kết nối Api Server
    - Tìm hiểu được về cách thêm C# script vào Game:
        - Học cú pháp C#.
        - Tạo object mới trong Unity, thêm C# để tương tác với object vừa tạo.
    - Tìm hiểu về cách viết C# để gọi RESTful APIs:
        - Tìm hiểu về RESTful APIs
        - Tập cách gọi API, sử dụng example api với các resource được cung cấp.
        - Dựng API Server.
        - Viết code C# để get/post data từ resource trên.
    - Kết nối với API server đã tạo:
        - Dựng server bằng nodejs đã dựng ở branch connect-rest-api.
        - Tìm hiểu về schema trong file json và đã sửa lại json theo logic của game.
        - Đã viết được GET request cho coin và star.
        - Viết được POST coin, star sau mỗi màn chơi.
    - Tạo được bảng điểm thống kê sau mỗi trận.
    - Lưu được thông tin của người chơi.
# 3. Những hạn chế

