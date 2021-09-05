import { Injectable } from '@angular/core';
import { Movie } from '../models/movie'

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  public API = 'https://localhost:44352';
  public MOVIE_API = `${this.API}/movie`;

  constructor(private http: HttpClient) { }

  getAllMovies() {
    let headers = new Headers();
    headers.append('Content-Type', 'application/x-www-form-urlencoded');
    headers.append('Access-Control-Allow-Origin', '*');
    headers.append('Accept', 'applcation/ json');
    let options = { headers: headers };
    return this.http.get<Array<Movie>>(this.MOVIE_API);
  }
}
