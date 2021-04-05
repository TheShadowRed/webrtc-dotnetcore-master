# WebRTC with ASP.NET Core
WebRTC allows direct peer-to-peer communication to work inside web pages.

## Signaling
A signaling server resolves how to connect two peers over the internet.
The signaling server in this demo uses SignalR to exchange the signaling information between the two peers.

## Connectivity
WebRTC connections may fail by restrictive networks behind NAT and firewalls.
To cope with NAT and firewalls, STUN and TURN servers are commonly used.
Since this demo uses only STUN server for traversal of NAT, the connection may fail if the two peers are in a different network and behind a network firewall or proxy.
