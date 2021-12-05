﻿CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

START TRANSACTION;

CREATE TABLE `AspNetRoles` (
    `Id` varchar(450) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` varchar(256) NULL,
    CONSTRAINT `PK_AspNetRoles` PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetUsers` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext CHARACTER SET utf8mb4 NULL,
    `SecurityStamp` longtext CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumberConfirmed` tinyint(1) NOT NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnd` datetime(6) NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    CONSTRAINT `PK_AspNetUsers` PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetRoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(450) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoleClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderKey` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderDisplayName` longtext CHARACTER SET utf8mb4 NULL,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserLogins` PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserRoles` (
    `UserId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    `RoleId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserRoles` PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    `LoginProvider` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserTokens` PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` (`RoleId`);

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` (`NormalizedName`);

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` (`RoleId`);

CREATE INDEX `EmailIndex` ON `AspNetUsers` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` (`NormalizedUserName`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211120134216_identity5', '5.0.11');

COMMIT;

START TRANSACTION;

ALTER TABLE `AspNetUsers` ADD `Address` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `AspNetUsers` ADD `Fullname` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `AspNetUsers` ADD `Photo` longtext CHARACTER SET utf8mb4 NULL;

CREATE TABLE `banners` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `photo` varchar(191) CHARACTER SET utf8mb4 NULL,
    `description` text CHARACTER SET utf8mb4 NULL,
    `condition` enum('banner','promo') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'banner',
    CONSTRAINT `PK_banners` PRIMARY KEY (`id`)
);

CREATE TABLE `brands` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    CONSTRAINT `PK_brands` PRIMARY KEY (`id`)
);

CREATE TABLE `categories` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `summary` text CHARACTER SET utf8mb4 NULL,
    `photo` varchar(191) CHARACTER SET utf8mb4 NULL,
    `is_parent` tinyint(1) NOT NULL DEFAULT '1',
    `parent_id` bigint(20) unsigned NULL,
    `added_by` varchar(255) NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'inactive',
    CONSTRAINT `PK_categories` PRIMARY KEY (`id`),
    CONSTRAINT `Categories_added_by_foreign` FOREIGN KEY (`added_by`) REFERENCES `AspNetUsers` (`Id`) ON DELETE SET NULL,
    CONSTRAINT `Categories_parent_id_foreign` FOREIGN KEY (`parent_id`) REFERENCES `categories` (`id`) ON DELETE SET NULL
);

CREATE TABLE `coupons` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `code` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `type` enum('fixed','percent') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'fixed',
    `value` decimal(20,2) NOT NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    `is_voucher` tinyint(1) NOT NULL,
    `quantity` int(11) NOT NULL,
    `started_at` timestamp NULL,
    `ended_at` timestamp NULL,
    CONSTRAINT `PK_coupons` PRIMARY KEY (`id`)
);

CREATE TABLE `messages` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `name` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `subject` text CHARACTER SET utf8mb4 NOT NULL,
    `email` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `photo` varchar(191) CHARACTER SET utf8mb4 NULL,
    `phone` varchar(191) CHARACTER SET utf8mb4 NULL,
    `message` longtext CHARACTER SET utf8mb4 NOT NULL,
    `read_at` timestamp NULL,
    CONSTRAINT `PK_messages` PRIMARY KEY (`id`)
);

CREATE TABLE `notifications` (
    `id` char(36) CHARACTER SET utf8mb4 NOT NULL,
    `type` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `notifiable_type` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `notifiable_id` bigint(20) unsigned NOT NULL,
    `data` text CHARACTER SET utf8mb4 NOT NULL,
    `read_at` timestamp NULL,
    CONSTRAINT `PK_notifications` PRIMARY KEY (`id`)
);

CREATE TABLE `postcategories` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    CONSTRAINT `PK_postcategories` PRIMARY KEY (`id`)
);

CREATE TABLE `posttags` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    CONSTRAINT `PK_posttags` PRIMARY KEY (`id`)
);

CREATE TABLE `settings` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `description` longtext CHARACTER SET utf8mb4 NOT NULL,
    `short_des` text CHARACTER SET utf8mb4 NOT NULL,
    `logo` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `photo` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `address` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `phone` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `email` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_settings` PRIMARY KEY (`id`)
);

CREATE TABLE `shippings` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `type` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `price` decimal(8,2) NOT NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    CONSTRAINT `PK_shippings` PRIMARY KEY (`id`)
);

CREATE TABLE `products` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `summary` text CHARACTER SET utf8mb4 NOT NULL,
    `description` longtext CHARACTER SET utf8mb4 NULL,
    `photo1` text CHARACTER SET utf8mb4 NOT NULL,
    `photo2` text CHARACTER SET utf8mb4 NOT NULL,
    `photo3` text CHARACTER SET utf8mb4 NOT NULL,
    `photo4` text CHARACTER SET utf8mb4 NOT NULL,
    `stock` int(11) NOT NULL DEFAULT '1',
    `condition` enum('default','new','hot') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'default',
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'inactive',
    `price` decimal(10) NOT NULL,
    `coupon_id` bigint(20) unsigned NULL,
    `cat_id` bigint(20) unsigned NULL,
    `child_cat_id` bigint(20) unsigned NULL,
    `brand_id` bigint(20) unsigned NULL,
    CONSTRAINT `PK_products` PRIMARY KEY (`id`),
    CONSTRAINT `Products_brand_id_foreign` FOREIGN KEY (`brand_id`) REFERENCES `brands` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Products_cat_id_foreign` FOREIGN KEY (`cat_id`) REFERENCES `categories` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Products_child_cat_id_foreign` FOREIGN KEY (`child_cat_id`) REFERENCES `categories` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Products_coupon_id_foreign` FOREIGN KEY (`coupon_id`) REFERENCES `coupons` (`id`) ON DELETE SET NULL
);

CREATE TABLE `posts` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `title` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `slug` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `summary` text CHARACTER SET utf8mb4 NOT NULL,
    `description` longtext CHARACTER SET utf8mb4 NULL,
    `quote` text CHARACTER SET utf8mb4 NULL,
    `photo` varchar(191) CHARACTER SET utf8mb4 NULL,
    `post_cat_id` bigint(20) unsigned NULL,
    `added_by` varchar(255) NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    CONSTRAINT `PK_posts` PRIMARY KEY (`id`),
    CONSTRAINT `Posts_added_by_foreign` FOREIGN KEY (`added_by`) REFERENCES `AspNetUsers` (`Id`) ON DELETE SET NULL,
    CONSTRAINT `Posts_post_cat_id_foreign` FOREIGN KEY (`post_cat_id`) REFERENCES `postcategories` (`id`) ON DELETE SET NULL
);

CREATE TABLE `orders` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `order_number` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `product_id` bigint(20) unsigned NULL,
    `user_id` varchar(255) NULL,
    `sub_total` decimal(10) NOT NULL,
    `shipping_id` bigint(20) unsigned NULL,
    `coupon_id` bigint(20) unsigned NULL,
    `total_amount` decimal(10) NOT NULL,
    `quantity` int(11) NOT NULL,
    `payment_method` enum('cod','paypal') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'cod',
    `payment_status` enum('paid','unpaid') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'unpaid',
    `status` enum('new','process','delivered','cancel') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'new',
    `first_name` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `last_name` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `email` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `phone` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `address` text CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_orders` PRIMARY KEY (`id`),
    CONSTRAINT `Orders_coupon_id_foreign` FOREIGN KEY (`coupon_id`) REFERENCES `coupons` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Orders_product_id_foreign` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Orders_shipping_id_foreign` FOREIGN KEY (`shipping_id`) REFERENCES `shippings` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Orders_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `AspNetUsers` (`Id`) ON DELETE SET NULL
);

CREATE TABLE `productattributes` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `color` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `price` decimal(10) NOT NULL,
    `stock` int(11) NOT NULL DEFAULT '1',
    `product_id` bigint(20) unsigned NULL,
    CONSTRAINT `PK_productattributes` PRIMARY KEY (`id`),
    CONSTRAINT `ProductAttributes_product_id_foreign` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE SET NULL
);

CREATE TABLE `productreviews` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `user_id` varchar(255) NULL,
    `product_id` bigint(20) unsigned NULL,
    `rating` tinyint(4) NOT NULL,
    `review` text CHARACTER SET utf8mb4 NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    CONSTRAINT `PK_productreviews` PRIMARY KEY (`id`),
    CONSTRAINT `ProductReviews_product_id_foreign` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE SET NULL,
    CONSTRAINT `ProductReviews_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `AspNetUsers` (`Id`) ON DELETE SET NULL
);

CREATE TABLE `postcomments` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `user_id` Varchar(255) NULL,
    `post_id` bigint(20) unsigned NULL,
    `comments` text CHARACTER SET utf8mb4 NOT NULL,
    `status` enum('active','inactive') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'active',
    `parent_id` bigint(20) unsigned NULL,
    CONSTRAINT `PK_postcomments` PRIMARY KEY (`id`),
    CONSTRAINT `PostComments_post_id_foreign` FOREIGN KEY (`post_id`) REFERENCES `posts` (`id`) ON DELETE SET NULL,
    CONSTRAINT `PostComments_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `AspNetUsers` (`Id`) ON DELETE SET NULL
);

CREATE TABLE `postsandtags` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `post_id` bigint(20) unsigned NULL,
    `tag_id` bigint(20) unsigned NULL,
    CONSTRAINT `PK_postsandtags` PRIMARY KEY (`id`),
    CONSTRAINT `PostsAndTags_post_id_foreign` FOREIGN KEY (`post_id`) REFERENCES `posts` (`id`) ON DELETE SET NULL,
    CONSTRAINT `PostsAndTags_post_tag_id_foreign` FOREIGN KEY (`tag_id`) REFERENCES `posttags` (`id`) ON DELETE SET NULL
);

CREATE TABLE `carts` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `product_id` bigint(20) unsigned NOT NULL,
    `order_id` bigint(20) unsigned NULL,
    `user_id` varchar(255) NULL,
    `price` decimal(10) NOT NULL,
    `status` enum('new','progress','delivered','cancel') CHARACTER SET utf8mb4 NOT NULL DEFAULT 'new',
    `quantity` int(11) NOT NULL,
    `amount` decimal(10) NOT NULL,
    CONSTRAINT `PK_carts` PRIMARY KEY (`id`),
    CONSTRAINT `Carts_order_id_foreign` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Carts_product_id_foreign` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE CASCADE,
    CONSTRAINT `Carts_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `wishlists` (
    `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
    `product_id` bigint(20) unsigned NOT NULL,
    `cart_id` bigint(20) unsigned NULL,
    `user_id` varchar(255) NULL,
    `color` varchar(191) CHARACTER SET utf8mb4 NOT NULL,
    `price` decimal(10) NOT NULL,
    `quantity` int(11) NOT NULL,
    `amount` decimal(10) NOT NULL,
    CONSTRAINT `PK_wishlists` PRIMARY KEY (`id`),
    CONSTRAINT `Wishlists_cart_id_foreign` FOREIGN KEY (`cart_id`) REFERENCES `carts` (`id`) ON DELETE SET NULL,
    CONSTRAINT `Wishlists_product_id_foreign` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE CASCADE,
    CONSTRAINT `Wishlists_user_id_foreign` FOREIGN KEY (`user_id`) REFERENCES `AspNetUsers` (`Id`) ON DELETE SET NULL
);

CREATE UNIQUE INDEX `Banners_slug_unique` ON `banners` (`slug`);

CREATE UNIQUE INDEX `Brands_slug_unique` ON `brands` (`slug`);

CREATE INDEX `Carts_order_id_foreign` ON `carts` (`order_id`);

CREATE INDEX `Carts_product_id_foreign` ON `carts` (`product_id`);

CREATE INDEX `Carts_user_id_foreign` ON `carts` (`user_id`);

CREATE INDEX `Categories_added_by_foreign` ON `categories` (`added_by`);

CREATE INDEX `Categories_parent_id_foreign` ON `categories` (`parent_id`);

CREATE UNIQUE INDEX `Categories_slug_unique` ON `categories` (`slug`);

CREATE UNIQUE INDEX `Coupons_code_unique` ON `coupons` (`code`);

CREATE INDEX `Notifications_notifiable_type_notifiable_id_index` ON `notifications` (`notifiable_type`, `notifiable_id`);

CREATE INDEX `Orders_coupon_id_foreign` ON `orders` (`coupon_id`);

CREATE UNIQUE INDEX `Orders_order_number_unique` ON `orders` (`order_number`);

CREATE INDEX `Orders_product_id_foreign` ON `orders` (`product_id`);

CREATE INDEX `Orders_shipping_id_foreign` ON `orders` (`shipping_id`);

CREATE INDEX `Orders_user_id_foreign` ON `orders` (`user_id`);

CREATE UNIQUE INDEX `PostCategories_slug_unique` ON `postcategories` (`slug`);

CREATE INDEX `PostComments_post_id_foreign` ON `postcomments` (`post_id`);

CREATE INDEX `PostComments_user_id_foreign` ON `postcomments` (`user_id`);

CREATE INDEX `Posts_added_by_foreign` ON `posts` (`added_by`);

CREATE INDEX `Posts_post_cat_id_foreign` ON `posts` (`post_cat_id`);

CREATE UNIQUE INDEX `Posts_slug_unique` ON `posts` (`slug`);

CREATE INDEX `PostsAndTags_post_id_foreign` ON `postsandtags` (`post_id`);

CREATE INDEX `PostsAndTags_post_tag_id_foreign` ON `postsandtags` (`tag_id`);

CREATE UNIQUE INDEX `PostTags_slug_unique` ON `posttags` (`slug`);

CREATE INDEX `ProductAttributes_product_id_foreign` ON `productattributes` (`product_id`);

CREATE INDEX `ProductReviews_product_id_foreign` ON `productreviews` (`product_id`);

CREATE INDEX `ProductReviews_user_id_foreign` ON `productreviews` (`user_id`);

CREATE INDEX `Products_brand_id_foreign` ON `products` (`brand_id`);

CREATE INDEX `Products_cat_id_foreign` ON `products` (`cat_id`);

CREATE INDEX `Products_child_cat_id_foreign` ON `products` (`child_cat_id`);

CREATE INDEX `Products_coupon_id_foreign` ON `products` (`coupon_id`);

CREATE UNIQUE INDEX `Products_slug_unique` ON `products` (`slug`);

CREATE INDEX `Wishlists_cart_id_foreign` ON `wishlists` (`cart_id`);

CREATE INDEX `Wishlists_product_id_foreign` ON `wishlists` (`product_id`);

CREATE INDEX `Wishlists_user_id_foreign` ON `wishlists` (`user_id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211205101308_test', '5.0.11');

COMMIT;

START TRANSACTION;

ALTER TABLE `AspNetUsers` DROP COLUMN `Address`;

ALTER TABLE `wishlists` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `wishlists` MODIFY COLUMN `amount` decimal(10) NOT NULL;

ALTER TABLE `products` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `productattributes` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `orders` MODIFY COLUMN `total_amount` decimal(10) NOT NULL;

ALTER TABLE `orders` MODIFY COLUMN `sub_total` decimal(10) NOT NULL;

ALTER TABLE `carts` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `carts` MODIFY COLUMN `amount` decimal(10) NOT NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211205101843_test2', '5.0.11');

COMMIT;

START TRANSACTION;

ALTER TABLE `wishlists` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `wishlists` MODIFY COLUMN `amount` decimal(10) NOT NULL;

ALTER TABLE `products` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `productattributes` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `orders` MODIFY COLUMN `total_amount` decimal(10) NOT NULL;

ALTER TABLE `orders` MODIFY COLUMN `sub_total` decimal(10) NOT NULL;

ALTER TABLE `carts` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `carts` MODIFY COLUMN `amount` decimal(10) NOT NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211205102220_test3', '5.0.11');

COMMIT;

START TRANSACTION;

ALTER TABLE `wishlists` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `wishlists` MODIFY COLUMN `amount` decimal(10) NOT NULL;

ALTER TABLE `products` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `productattributes` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `orders` MODIFY COLUMN `total_amount` decimal(10) NOT NULL;

ALTER TABLE `orders` MODIFY COLUMN `sub_total` decimal(10) NOT NULL;

ALTER TABLE `carts` MODIFY COLUMN `price` decimal(10) NOT NULL;

ALTER TABLE `carts` MODIFY COLUMN `amount` decimal(10) NOT NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211205103427_test4', '5.0.11');

COMMIT;

