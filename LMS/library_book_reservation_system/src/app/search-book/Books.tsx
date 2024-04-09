import React, { FC, useState } from "react";
import PropTypes from "prop-types";
import BookInfo from "./BookInfo";

import './Books.module.css'

interface BookCardProps {
  book: Array<any>;
}

const BookCard: FC<BookCardProps> = ({ book }) => {
  console.log(book);

  const [show, setShow] = useState<boolean>(false);
  const [bookItem, setBookItem] = useState<any>();

  return (
    <>

      {book.map((item: any) => {
        let thumbnail =
          item.volumeInfo.imageLinks &&
          item.volumeInfo.imageLinks.smallThumbnail;
        {
          /* let thumbnail = item.volumeInfo.imageLinks && item.volumeInfo.imageLinks.smallThumbnail; */
        }
        if (thumbnail !== undefined) {
          return (
            <>
              {console.log(item)}
              <div
                className="card"
                onClick={() => {
                  setShow(true);
                  setBookItem(item);
                }}
              >
                <img src={thumbnail} alt="" />
                <div className="bottom">
                  <h3 className="title"> Title: {item.volumeInfo.title}</h3>
                </div>
              </div>
              <BookInfo
                show={show}
                item={bookItem}
                onClose={() => setShow(false)}
              />
              {console.log(thumbnail)}
            </>
          );
        }
      })}
    </>
  );
};

BookCard.propTypes = {
  book: PropTypes.array.isRequired,
};

export default BookCard;