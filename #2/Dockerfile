FROM ubuntu:latest
LABEL maintainer = "g.mikele@gmail.com"
RUN apt update -y
   &&  apt install -y python-pip python-dev build-essential
   && rm -rf /var/lib/apt/lists/*
COPY . /app
WORKDIR /app
RUN pip install -r requirements.txt
EXPOSE 5000
ENTRYPOINT ["python"]
CMD ["app.py"]