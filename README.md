# MongoDbSamples

������ MongoDB � ����������:
```
cd .\MongoDbSamples\
docker-compose up -d
```
������� � ��������� � MongoDB:
```
docker exec -it mongodb bash
```
�������� ��������� ��������� �������� MongoDB:
```
mongosh
```
������� ���� ������ � ������ BookStore:
```
use BookStore
```
������� ��������� Books:
```
db.createCollection('Books')
```
���������� ����� ��� ��������� Books � �������� �������� ������:
```
db.Books.insertMany([{ "Name": "Design Patterns", "Price": 54.93, "Category": "Computers", "Author": "Ralph Johnson" }, { "Name": "Clean Code", "Price": 43.15, "Category": "Computers","Author": "Robert C. Martin" }])
```
���������� ���������:
```
db.Books.find().pretty()
```

