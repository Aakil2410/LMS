import React, { FC } from "react";
// import './BookInfo.module.css'

interface BookInfoProps {
  show: boolean;
  item: {
    volumeInfo: {
      title: string;
      authors: string[];
      publisher: string;
      publishedDate: string;
      description: string;
      previewLink: string;
      imageLinks: {
        smallThumbnail: string;
      };
      industryIdentifiers: {
        type: string;
        identifier: string;
      }[];
    };
  };
  onClose: () => void;
}

const BookInfo: FC<BookInfoProps> = ({ show, item, onClose }) => {
  if (!show) {
    return null;
  }
  let thumbnail =
    item.volumeInfo.imageLinks && item.volumeInfo.imageLinks.smallThumbnail;
  const bookISBN:string =
    item.volumeInfo.industryIdentifiers &&
    item.volumeInfo.industryIdentifiers.identifier;
  localStorage.setItem("bookISBN", bookISBN);
  return (
    <>
      <div className="overlay">
        <div className="overlay-inner">
          <button className="close" onClick={onClose}>
            X
          </button>

          <div className="inner-box">
            <img src={thumbnail} alt="" />
            <div className="info">
              <h1>{item.volumeInfo.title}</h1>
              <h3>Author: {item.volumeInfo.authors}</h3>
              <h4>
                Publisher: {item.volumeInfo.publisher}
                <span>{item.volumeInfo.publishedDate}</span>
              </h4>
              <br />
              {/* <h4>{item.volumeInfo.industryIdentifiers[1].identifier}</h4> */}
              {/* <a href={item.volumeInfo.previewLink} target="_blank">
                <button>Read</button>
              </a> */}
              {/* <a href={"src/Reader.html"} target="_blank"> <button> Read</button> </a> */}
            </div>
          </div>
          <p className="description">{item.volumeInfo.description}</p>
        </div>
      </div>
    </>
  );
};

export default BookInfo;
