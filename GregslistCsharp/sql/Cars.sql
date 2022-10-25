-- Active: 1666715466993@@SG-berry-server-8496-6844-mysql-master.servers.mongodirector.com@3306@SqlDb

CREATE TABLE
    IF NOT EXISTS cars(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        make VARCHAR(255) NOT NULL,
        model VARCHAR(255) NOT NULL,
        year INT NOT NULL CHECK(year >= 1985),
        price DECIMAL(10, 2) NOT NULL CHECK(price >= 0),
        description VARCHAR(255),
        imgUrl VARCHAR(255) DEFAULT "https://www.autolist.com/assets/listings/default_car.jpg "
    );

INSERT INTO
    cars(
        make,
        model,
        year,
        price,
        description,
        imgUrl
    )
VALUES (
        "KFC eeee",
        "Bucket Tré",
        1985,
        999,
        "Yum Yum!!",
        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJcEQw9jHNAmFu-VTA7bhvZhMugoz0q_r0oeTUswAO&s"
    );

SELECT * FROM cars;

SELECT * FROM cars WHERE id = 2;