# Install docker

    sudo apt-get install docker

# Give root to docker

    sudo gpasswd -a ${USER} docker
    sudo service docker restart

Restart/login again or something
 
# Run build script

    ./build.sh

## Find the image you just build

    docker images

## Start the docker images
Look for the right containername (this could be done automatic, maybe from a Docker build task?)

    docker run -i -p 127.0.0.1:50000:50000 595f9e8e217b

## Profit
Open in the browser 127.0.0.1:50000

