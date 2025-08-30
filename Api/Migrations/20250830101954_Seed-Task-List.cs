using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedTaskList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Прежде напрямую участниками.", "Cancelled", "Используйте свободно-распростроняемый XSS парсер, для того чтобы квантифицировать свободно-распростроняемый парсер!" },
                    { 2, "Же требует опыт.", "Planned", "Чтобы ввести ограничитель, мы можем получить ЭВМ ограничитель через 1080-пиксельный ЭВМ ограничитель!" },
                    { 3, "Концепция сознания различных информационно-пропогандистское не.", "Review", "Чтобы импортировать кортеж, мы можем получить ОС кортеж через свободно-распростроняемый ОС кортеж!" },
                    { 4, "Образом значимость повседневной вызывает также.", "Planned", "Я планирую разобрать твердотельный FTP кортеж, это должно помочь разобрать FTP кортеж!" },
                    { 5, "Соответствующих задач принимаемых.", "InProgress", "Попробуйте импортировать ПЗУ конденсатор, возможно это позволит импортировать мобильный конденсатор!" },
                    { 6, "Процесс создаёт с модель.", "Planned", "HTTP массив недоступен, требуется экспортировать вспомогательный массив, чтобы мы могли экспортировать HTTP массив!" },
                    { 7, "Систему управление сложившаяся.", "Review", "Попробуйте генерировать PCI объект, возможно это позволит генерировать излишний объект!" },
                    { 8, "Потребностям настолько внедрения высшего.", "Cancelled", "ЭВМ кортеж недоступен, требуется зашифровать онлайн кортеж, чтобы мы могли зашифровать ЭВМ кортеж!" },
                    { 9, "Обуславливает повышение разнообразный сфера этих.", "Planned", "Я планирую передать оптический ХЗ блок разведения, это должно помочь передать ХЗ блок разведения!" },
                    { 10, "Эксперимент от плановых деятельности изменений.", "OnHold", "Попробуйте обойти SMTP конденсатор, возможно это позволит обойти кросс-платформенный конденсатор!" },
                    { 11, "Намеченных богатый напрямую.", "Rejected", "Чтобы сохранить микрочип, мы можем получить SDD микрочип через сенсорный SDD микрочип!" },
                    { 12, "Понимание задача представляет плановых.", "Done", "Используйте твердотельный PNG механизм сигнализации, для того чтобы сохранить твердотельный механизм сигнализации!" },
                    { 13, "Значение порядка вызывает.", "Planned", "Чтобы ввести механизм сигнализации, мы можем получить XSS механизм сигнализации через беспроводной XSS механизм сигнализации!" },
                    { 14, "Структуры играет всего.", "Cancelled", "Необходимо перезагрузить цифровой HTTP брандмауэр!" },
                    { 15, "Создаёт позиции уточнения.", "OnHold", "Попробуйте разобрать FTP объект, возможно это позволит разобрать мобильный объект!" },
                    { 16, "Мира сомнений создание требует.", "Cancelled", "соединение не работает, попробуйте ввести кросс-платформенный USB код!" },
                    { 17, "Правительством не нашей форм повседневная.", "Testing", "Вы не можете импортировать винчестер, требуется шифрование или шифрование!" },
                    { 18, "Очевидна внедрения не.", "InProgress", "Чтобы копировать парсер, мы можем получить EXE парсер через онлайн EXE парсер!" },
                    { 19, "Экономической повышению участия материально-технической.", "Planned", "генерация не работает, попробуйте экспортировать цифровой XSS парсер!" },
                    { 20, "Задача кадров прогрессивного.", "Rejected", "Используйте онлайн ПЗУ ограничитель, для того чтобы запрограммировать онлайн ограничитель!" },
                    { 21, "Намеченных качества повседневная модели направлений.", "Rejected", "Необходимо распарсить онлайн FTP ключ!" },
                    { 22, "Поэтапного таким материально-технической от.", "Planned", "Необходимо синтезировать онлайн НМЖД пиксель!" },
                    { 23, "Соответствующей социально-ориентированный значение определения.", "Rejected", "Попробуйте синтезировать USB протокол, возможно это позволит синтезировать кросс-платформенный протокол!" },
                    { 24, "Задача подготовке показывает всего.", "Testing", "копирование не работает, попробуйте передать сенсорный БИОС сокет!" },
                    { 25, "Начало формированию структура структуры.", "Planned", "Используйте излишний ЭВМ брандмауэр, для того чтобы индексировать излишний брандмауэр!" },
                    { 26, "Анализа информационно-пропогандистское влечёт настолько принимаемых.", "InProgress", "Я планирую импортировать цифровой Гб кортеж, это должно помочь импортировать Гб кортеж!" },
                    { 27, "Гражданского богатый новых отметить.", "OnHold", "JSON протокол недоступен, требуется взломать 1080-пиксельный протокол, чтобы мы могли взломать JSON протокол!" },
                    { 28, "Последовательного оценить постоянный рост прежде.", "Cancelled", "Чтобы синтезировать брандмауэр, мы можем получить SMTP брандмауэр через сенсорный SMTP брандмауэр!" },
                    { 29, "Равным широким прежде от сфера.", "Done", "Чтобы взломать микрочип, мы можем получить FTP микрочип через 1080-пиксельный FTP микрочип!" },
                    { 30, "Гражданского направлений сомнений.", "OnHold", "Используйте кросс-платформенный COM протокол, для того чтобы вычислить кросс-платформенный протокол!" },
                    { 31, "Же забывать оценить модернизации.", "Testing", "Необходимо копировать цифровой ПЗУ конденсатор!" },
                    { 32, "Модели предложений условий гражданского сознания.", "Done", "Чтобы распарсить винчестер, мы можем получить CSS винчестер через оптический CSS винчестер!" },
                    { 33, "Оценить уточнения постоянное таким.", "Rejected", "Попробуйте генерировать Гб протокол, возможно это позволит генерировать онлайн протокол!" },
                    { 34, "Дальнейшее значимость богатый.", "Review", "Необходимо вычислить кросс-платформенный COM монитор!" },
                    { 35, "Различных задания обеспечивает значение.", "Rejected", "Используйте твердотельный PCI интерфейс, для того чтобы распарсить твердотельный интерфейс!" },
                    { 36, "Административных целесообразности начало требует важные.", "Planned", "Попробуйте взломать ОЗУ массив, возможно это позволит взломать внутренний массив!" },
                    { 37, "Занимаемых воздействия анализа.", "Review", "соединение не работает, попробуйте разобрать онлайн SSL кортеж!" },
                    { 38, "Постоянное предпосылки участниками технологий.", "OnHold", "Чтобы передать интерфейс, мы можем получить ADP интерфейс через внутренний ADP интерфейс!" },
                    { 39, "Модель сомнений этих этих актуальность.", "Review", "Чтобы синтезировать механизм сигнализации, мы можем получить ЭВМ механизм сигнализации через кросс-платформенный ЭВМ механизм сигнализации!" },
                    { 40, "Ресурсосберегающих шагов обеспечение инновационный.", "Planned", "Я планирую переопределить излишний AGP винчестер, это должно помочь переопределить AGP винчестер!" },
                    { 41, "Создаёт организации организационной влечёт.", "Cancelled", "обход не работает, попробуйте разобрать онлайн ОС код!" },
                    { 42, "Административных и анализа показывает.", "OnHold", "Используйте свободно-распростроняемый ПО кортеж, для того чтобы распарсить свободно-распростроняемый кортеж!" },
                    { 43, "Представляет широкому сомнений.", "Planned", "Вы не можете разобрать брандмауэр, требуется программирование или программирование!" },
                    { 44, "Также нас активности.", "Review", "ОС сокет недоступен, требуется индексировать сенсорный сокет, чтобы мы могли индексировать ОС сокет!" },
                    { 45, "Отношении насущным отметить укрепления от.", "Cancelled", "Чтобы перезагрузить интерфейс, мы можем получить EXE интерфейс через виртуальный EXE интерфейс!" },
                    { 46, "Консультация кадровой рост.", "InProgress", "Чтобы вычислить кортеж, мы можем получить PNG кортеж через цифровой PNG кортеж!" },
                    { 47, "Обеспечивает высшего с.", "Rejected", "Используйте внутренний XSS парсер, для того чтобы передать внутренний парсер!" },
                    { 48, "Другой создаёт однако по национальный.", "OnHold", "Попробуйте запрограммировать ЭВМ кортеж, возможно это позволит запрограммировать мобильный кортеж!" },
                    { 49, "Разнообразный модель модернизации играет таким.", "Cancelled", "Используйте внутренний Гб конденсатор, для того чтобы ввести внутренний конденсатор!" },
                    { 50, "Важные ресурсосберегающих образом демократической кадровой.", "Testing", "Вы не можете ввести массив, требуется навигация или навигация!" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
