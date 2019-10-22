$ docker build -t aspnetapp .
$ docker run -d -p 8080:80 --name myapp aspnetapp

$ docker build -t boriphuth/globalgrrorhandling .
$ docker run -d -p 8080:80 --name globalgrrorhandling boriphuth/globalgrrorhandling

docker run -p 8888:80 --name globalgrrorhandling boriphuth/globalgrrorhandling