import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Post } from 'src/app/model/post.model';
import { ApiService } from 'src/app/shared/service/api/api.service';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  readonly _baseAPIControl = 'Post';

  constructor(private readonly _apiService: ApiService) {
  }

  getPosts(): Observable<Post[]> {
    return this._apiService.get(this._baseAPIControl);
  }
}
