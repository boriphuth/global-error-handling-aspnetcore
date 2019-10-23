$ docker build -t aspnetapp .
$ docker run -d -p 8080:80 --name myapp aspnetapp

$ docker build -t boriphuth/globalgrrorhandling .
$ docker push boriphuth/globalgrrorhandling
$ docker run -d -p 8080:80 --name globalgrrorhandling boriphuth/globalgrrorhandling

docker run -p 8888:80 --name globalgrrorhandling boriphuth/globalgrrorhandling


docker run --name=nginx -d -v ~/nginxlogs:/var/log/nginx -p 5000:80 nginx


## https://www.digitalocean.com/community/tutorials/how-to-share-data-between-the-docker-container-and-the-host

docker run -d -v ~/logs:/app/logs -p 8080:80 --name globalgrrorhandling boriphuth/globalgrrorhandling
cd ~/logs