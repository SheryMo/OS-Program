#! /bin/bash

qemu-system-x86_64 -m 16M -s -S -fda ~/linux-0.11-lab/0.11/Image -hda linux-0.11-lab/rootfs/hdc-0.11.img -boot a
