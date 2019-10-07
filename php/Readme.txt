docker build -t sitio-php:latest -f Dockerfile .

docker run -d --name php-web -P sitio-php:latest