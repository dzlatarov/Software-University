package softuniBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import softuniBlog.entity.Article;

/**
 * Created by Lenovo Y700 on 4/6/2017.
 */
public interface ArticleRepository extends JpaRepository<Article, Integer> {

}
