// HousingSolutions.DeviceGateway.cpp : This file contains the 'main' function. Program execution begins and ends there.
#include <iostream>
#include <winsock2.h>
#pragma comment(lib, "ws2_32.lib")

int main() {
    WSADATA wsa;
    SOCKET s, new_socket;
    struct sockaddr_in server, client;
    int c;
    char buffer[1024];

    WSAStartup(MAKEWORD(2, 2), &wsa); // returns nothing, only required to use sockets on windows
    s = socket(AF_INET, SOCK_STREAM, 0);

    server.sin_family = AF_INET;
    server.sin_addr.s_addr = INADDR_ANY;
    server.sin_port = htons(5050);// Listens port 5050
    bind(s, (struct sockaddr*)&server, sizeof(server));//sets up the server
    listen(s, 3);

    std::cout << "DeviceGateway listening on port 5050...\n";

    c = sizeof(struct sockaddr_in);
    while ((new_socket = accept(s, (struct sockaddr*)&client, &c)) != INVALID_SOCKET) {
        int read_size;
        while ((read_size = recv(new_socket, buffer, 1024, 0)) > 0) {
            buffer[read_size] = '\0';
            std::cout << "Command received: " << buffer << std::endl;
            send(new_socket, "ACK\n", 4, 0);
        }
        closesocket(new_socket);
    }

    closesocket(s);
    WSACleanup();
    return 0;
}

