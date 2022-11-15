FROM alpine:3

RUN apk add --no-cache curl
RUN wget -q -O /etc/apk/keys/sgerrand.rsa.pub https://alpine-pkgs.sgerrand.com/sgerrand.rsa.pub
RUN wget https://github.com/sgerrand/alpine-pkg-glibc/releases/download/2.35-r0/glibc-2.35-r0.apk
RUN apk add glibc-2.35-r0.apk

RUN curl -L -o butler.zip https://broth.itch.ovh/butler/linux-amd64/LATEST/archive/default && unzip -d /usr/local/bin butler.zip
RUN chmod +x /usr/local/bin/butler
ENTRYPOINT [ "/usr/local/bin/butler" ]
CMD [ "help" ]
