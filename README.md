# MongoDbSamples

Запуск MongoDB в контейнере:
```
cd .\MongoDbSamples\
docker-compose up -d
```
Перейти в контейнер с MongoDB:
```
docker exec -it mongodb bash
```
Откройте экземпляр командной оболочки MongoDB:
```
mongosh
```
Создать база данных с именем BookStore:
```
use BookStore
```
Создать коллекцию Books:
```
db.createCollection('Books')
```
Определите схему для коллекции Books и вставить тестовые данные:
```
db.Books.insertMany([{ "Name": "Design Patterns", "Price": 54.93, "Category": "Computers", "Author": "Ralph Johnson" }, { "Name": "Clean Code", "Price": 43.15, "Category": "Computers","Author": "Robert C. Martin" }])
```
Посмотреть результат:
```
db.Books.find().pretty()
```

