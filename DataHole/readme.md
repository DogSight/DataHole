#DataHole

##Build Project
docker build -t datahole .

##Run Project
docker run -d -p 8080:80 --name datahole aspnetapp