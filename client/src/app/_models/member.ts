import { Card } from "./card";
import { Photo } from "./photo";

export interface Member {
        id: number;
        username: string;
        photoUrl: string;
        age: number;
        created: Date;
        lastActive: Date;
        gender: string;
        city: string;
        country: string;
        photos: Photo[];
        cards: Card[];
    }