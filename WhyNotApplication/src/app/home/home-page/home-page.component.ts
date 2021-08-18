import { Component, OnInit } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { PostService } from 'src/app/service/post-service/post.service';
import { BaseComponent } from 'src/app/shared/component/base/base.component';

@Component({
  selector: 'what-hub-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent extends BaseComponent implements OnInit {

  dataSource: any;

  constructor(private readonly postService: PostService) {
    super();
  }

  ngOnInit(): void {
    this.execute(this.postService.getPosts())
      .pipe(
        finalize(() => {
        }))
      .subscribe(dataResponse => {
        this.dataSource = dataResponse;
      });
  }

}
